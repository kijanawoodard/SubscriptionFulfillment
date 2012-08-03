using System.Web.Mvc;
using NServiceBus;
using SubscriptionFulfillment.Messages.Commands;

namespace SubscriptionFulfillment.Web.Controllers
{
    public class SubscriptionController : Controller
    {
        public IBus Bus { get; set; }

        [HttpGet]
        public ActionResult Enroll()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Enroll(EnrollSubscriber command)
        {
            Bus.Send(command);
            return RedirectToAction("EnrollmentSubmitted");
        }

        [HttpGet]
        public ActionResult EnrollmentSubmitted()
        {
            return View();
        }

        public ActionResult Cancel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cancel(CancelSubscriber command)
        {
            Bus.Send(command);
            return RedirectToAction("CancellationSubmitted");
        }

        [HttpGet]
        public ActionResult CancellationSubmitted()
        {
            return View();
        }
    }
}
