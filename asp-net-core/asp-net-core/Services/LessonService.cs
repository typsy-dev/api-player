using asp_net_core.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_net_core.Services
{
    public class LessonService
    {
        public static Lesson Get(int id)
        {
            // Implement the logic here to call the Typsy API and return a Lesson

            // For demonstration purposes we are manually creating a Lesson object.
            Lesson lesson = new Lesson();
            lesson.Id = id;
            lesson.Name = "Typsy lesson";
            lesson.PlayerId = "j38ihh83m5"; // The ID used here is for a sample provided by the video player wistia.com
            lesson.Language = "en-AU";
            lesson.Length = 100;
            lesson.GracePeriod = 10;
            lesson.Instructor = new Instructor();
            lesson.Instructor.Name = "Instructor Bob";

            return lesson;
        }
    }
}
