using System;
using System.Threading;
namespace Homework4
{
    public delegate void ClickHandler(Object sender, ClickEventArgs args);
    public class ClickEventArgs{
        public string date{get; set;}
        public string time{get; set;}
    }
    public class Button
    {
        public event ClickHandler onClickTick;
        public event ClickHandler onClickAlarm;
        public void clickTick(){
            while (true) {
                ClickEventArgs args = new ClickEventArgs(){
                date = DateTime.Now.ToShortDateString().ToString(),
                time = DateTime.Now.ToLongTimeString().ToString()
                };
                Console.WriteLine($"{args.date}-{args.time}.");
                onClickTick(this, args);
                Thread.Sleep(1000);
            }
        }
        public void clickAlarm(){
                ClickEventArgs args = new ClickEventArgs(){
                date = DateTime.Now.ToShortDateString().ToString(),
                time = DateTime.Now.ToLongTimeString().ToString()
                };
                onClickAlarm(this, args);
                Thread.Sleep(1000);
        }
    }
    public class Clock{
        public Button button1 = new Button();
        public Clock(){
            button1.onClickTick += new ClickHandler(Btn_tick);
            button1.onClickAlarm += new ClickHandler(Btn_alarm);
        }
        public void Btn_tick(Object sender, ClickEventArgs args){}
        public void Btn_alarm(Object sender, ClickEventArgs args){
            String s = "";
            int count = 0;
            Console.WriteLine("Which time do you want to alarm?");
            s = Console.ReadLine();
            while (count == 0)
            {
                args.time = DateTime.Now.ToLongTimeString().ToString();
                if (args.time != s)
                {
                    Console.WriteLine(args.time);
                    Thread.Sleep(500);
                }
                else
                {
                    count = 1;
                    Console.WriteLine("It's time to ring.");
                }
            }
        }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            Clock clock1 = new Clock();
            clock1.button1.clickAlarm();
            clock1.button1.clickTick();
        }
    }
}
