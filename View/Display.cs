using System.Collections.Generic;
using calendar.Controller;
using System;

namespace calendar.View{

    public class Display{

        public Display(){
            Business.ClearEntries();
            Business.AddParents("Pesho");
            List<string> parents = Business.GetParents();
            foreach(string parent in parents)
                System.Console.WriteLine(parent);
        }

    }

}