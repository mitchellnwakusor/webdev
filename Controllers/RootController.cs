using System;
using Microsoft.AspNetCore.Mvc;

namespace squareroot.Controllers
{
    public class RootController : Controller{

        [HttpGet]
        public ActionResult sqrRoot(){
            return View();
        }
        [HttpPost]
        public ActionResult sqrRoot(string firstNumber, string secondNumber){
            int number1 = int.Parse(firstNumber);
            double rootNo1 = Math.Sqrt(number1);
            int number2 = int.Parse(secondNumber);
            double rootNo2 = Math.Sqrt(number2);
            string reply = "hello";
            ViewBag.noResult1 = number1;
            ViewBag.noResult2 = number2;
            ViewBag.Result1 = rootNo1;
            ViewBag.Result2 = rootNo2;

            if(ViewBag.Result1>ViewBag.Result2){
                reply = "the number " + ViewBag.noResult1 + " with a square root of " + ViewBag.Result1 + " is greater than the number " + ViewBag.noResult2 + " with square root of " + ViewBag.Result2;
            }
           else if(ViewBag.Result1<ViewBag.Result2){
                reply = "the number " + ViewBag.noResult1 + " with a square root of " + ViewBag.Result1 + " is less than the number " + ViewBag.noResult2 + " with square root of " + ViewBag.Result2;
            }
           else if(ViewBag.Result1==ViewBag.Result2){
                reply = "the number " + ViewBag.noResult1 + " with a square root of " + ViewBag.Result1 + " is equal to the number " + ViewBag.noResult2 + " with square root of " + ViewBag.Result2;
            }
            else{
                reply = "error, please try again";
            }
            ViewBag.message = reply;
            return View();
        }
    }
}
