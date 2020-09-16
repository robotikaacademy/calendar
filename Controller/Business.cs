using System.Collections.Generic;
using calendar.Model.Models;
using System.Linq;
using calendar.Model;
using System;

namespace calendar.Controller{

    public static class Business{

        private static Context context;

        public static void AddParents(string name){
            using(context = new Context()){
                    tab_course newParent = new tab_course();
                    newParent.name = name;
                    newParent.age_group = "";
                    newParent.date_start = new DateTime();
                    newParent.date_end = new DateTime();
                    newParent.free_places = 0;
                    newParent.level = "";

                    context.tab_course.Add(newParent);
                    context.SaveChanges();

            }
        }

        public static List<string> GetParents(){
            using(context = new Context()){
                return context.tab_course.Select(x => x.name).ToList();
            }
        }

        public static void ClearEntries(){
            using(context = new Context()){
                while(context.tab_course.ToList().Count > 0){

                    context.tab_course.Remove(context.tab_course.First());
                    context.SaveChanges();

                }
            }
        }

    }

}