using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace POOActivities
{
    // To make tick https://docs.microsoft.com/en-us/dotnet/api/system.timers.timer?redirectedfrom=MSDN&view=netframework-4.7.2
    class Clock
    {
        private Date date;
        private int hour;
        private int minute;
        private int second;

        private Timer tick;

        public void reset(){
            hour = 0;
            minute = 0;
            second = 0;
            date.Day = 1;
            date.Month = 1;
            date.Year = 2000;
        }

        public Clock(){
            date = new Date(1, 1, 2000);

            tick = new Timer(1000);
            tick.Elapsed += Tick;
            tick.AutoReset = true;
            tick.Start();
        }

        public void addSeconds(int seconds = 1){
            second += seconds;

            while(second >= 60){
                if(minute == 59){
                    if(hour == 23){
                        date.AddDays(1);
                        hour = 0;
                    }
                    else{
                        hour++;
                    }
                    minute = 0;
                }
                else{
                    minute++;
                }
                second--;
            }
        }

        private void Tick(Object source, ElapsedEventArgs e){
            addSeconds();
        }

        public override string ToString(){
            return date.Day + "/" + date.Month + "/" + date.Year + " " +
                       hour + ":" + minute + ":" + second;
        }


    }
}
