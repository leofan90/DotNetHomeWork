using System;

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
            ClickEventArgs args = new ClickEventArgs(){
                date = DateTime.Now.ToShortDateString().ToString(),
                time = DateTime.Now.ToShortTimeString().ToString()
            };
            Console.WriteLine($"The clock has been clicked. The data is {args.date}, time is {args.time}.");
            onClickTick(this, args);
        }
        public void clickAlarm(){
            ClickEventArgs args = new ClickEventArgs(){
                date = DateTime.Now.ToShortDateString().ToString(),
                time = DateTime.Now.ToShortTimeString().ToString()
            };
            onClickAlarm(this, args);
        }
    }
    public class Clock{
        public Button button1 = new Button();
        private int count = 0;
        public Clock(){
            button1.onClickTick += new ClickHandler(Btn_tick);
            button1.onClickAlarm += new ClickHandler(Btn_alarm);
        }
        public void Btn_tick(Object sender, ClickEventArgs args){
            if (count == 0)
            {
                Console.WriteLine("The clock is start ticking.");
                count = 1;
            }
            else
            {
                Console.WriteLine("The ticking is stopped.");
            }
        }
        public void Btn_alarm(Object sender, ClickEventArgs args){
            String s = "";
            Console.WriteLine("Which time do you want to alarm?");
            s = Console.ReadLine();
            while (args.time != s)
            {
                args.time = DateTime.Now.ToShortTimeString().ToString();
            }
            Console.WriteLine("It's time to ring.");
        }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            Clock clock1 = new Clock();
            clock1.button1.clickTick();
            clock1.button1.clickTick();
            clock1.button1.clickAlarm();
        }
    }
}
