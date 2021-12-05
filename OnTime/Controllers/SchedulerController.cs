using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using OnTime.Interfaces;
using OnTime.Models;
using OnTime.Models.Viewmodels;
using OnTime.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OnTime.Controllers
{
  
    public class SchedulerController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public List<SchedulerModel> GoogleEvents = new List<SchedulerModel>();
        private readonly ISchedulingService _schedulingService;
        private readonly ApplicationDbContext _db;
        static string[] Scopes = { CalendarService.Scope.CalendarReadonly };
        static string ApplicationName = "Google Calendar API .NET Quickstart";

        public SchedulerController(ISchedulingService schedulingService,IWebHostEnvironment webHostEnvironment,ApplicationDbContext db)
            {
            _schedulingService = schedulingService;
            _webHostEnvironment = webHostEnvironment;
            _db = db;
            }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ScheduleManager()
        {
            SchedulerApi();

            IEnumerable<ScheduleViewModel> schedule  =   _schedulingService.GetSchedule();

            return View(schedule);
        }

        public void SchedulerApi()
        {
            UserCredential credential;
            string contentRootPath = _webHostEnvironment.ContentRootPath;
            string path = Path.Combine(contentRootPath, "Credential.json");
            using (var stream =
                new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                
            }

            // Create Google Calendar API service.
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define parameters of request.
            EventsResource.ListRequest request = service.Events.List("primary");
            request.TimeMin = DateTime.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 10;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            // List events.
            Events events = request.Execute();
            
            if (events.Items != null && events.Items.Count > 0)
            {
                foreach (var eventItem in events.Items)
                {

                    SchedulerModel scheduler = new SchedulerModel
                    {
                        CreatedBy = eventItem.Organizer.Email,
                        ShiftType = eventItem.Description,
                        Employee = eventItem.Summary,
                        EndTime = eventItem.End.DateTime.ToString(),
                        startTime = eventItem.Start.DateTime.ToString(),
                      

                    };

                    var checkSchedule = _db.Schedules.Where(s => s.startTime == eventItem.Start.DateTime.ToString() && s.Employee == eventItem.Summary).FirstOrDefault();
                    if (checkSchedule == null)
                    {
                        _schedulingService.InsertSchedule(scheduler);
                    }
                    else
                    {
                        

                    }
                    

                }
            }
           
        }

       
    }
}
