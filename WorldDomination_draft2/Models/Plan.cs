using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WorldDomination_draft2.Models
{
    public class Plan
    {
        public int planId { get; set; }
        public string name { get; set; }
        public string country { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? date { get; set; } //date picker

        [Display(Name="Method")]
        public string takeoverMethod { get; set; } //dropdown

        public IEnumerable<SelectListItem> takeoverMethodList
        {
            get
            {
                List<SelectListItem> methodList = new List<SelectListItem>();
                methodList.Add(new SelectListItem { Text = "space lasers", Value = "space lasers" });
                methodList.Add(new SelectListItem { Text = "earhtquake", Value = "earhtquake" }); 
                methodList.Add(new SelectListItem { Text = "weather control device", Value = "weather control device" }); 
                methodList.Add(new SelectListItem { Text = "giant robot", Value = "giant robot" });

                return methodList;
            }
        }

        //constructor
        public Plan (int id, string name, string country, DateTime date, string method)
        {
            this.planId = id;
            this.name = name;
            this.country = country;
            this.date = date;
            this.takeoverMethod = method;
        }

        //constructor
        public Plan()
        {
            this.planId = 0;
            this.name = "";
            this.country = "";
            this.date = null;
            this.takeoverMethod = "";
        }



    }
}