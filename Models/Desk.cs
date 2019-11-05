using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWeb._0.Models
{
    public class Desk
    {
        /*
         * 1.0 requirements:
         MainMenu.cs form html
         AddQuote view/form
         DisplayQuote View
         ViewAllQuote View
         SearchQuote form
         Class Desk, DeskQuote
         Support nav between each other

        VAlidation width, height, drawers, material.

        take input from deskquote
        CustomerName
        DeskWidth
        DeskDepth
        NubmerDrawers
        Material
        RushOrderSElection
        Display the Quote Date

        Once exception handleing
        table for materials, photo, and price.
        make sure Material is a dropdown
        Rush Days dropdown as well.
        
        2.0 requirements:
        instance of List
        search through orders by combo box. 
        Page with all quotes

        table for rush order pricing
         link tables back to the main table which is the orders.

        3.0 requirements:
        should not look like original tutorial. make app like.
        store quotes in database
        deskQuote contains required fields.
        user must be able to view all quotes, sort by date or name only.
        Add a new quote
        edit exiting qoutes
        delete quotes
        search quotes by customer name
        input should be validated
        visual clue for desk materials. store name of image
        how to display?


        4 tables:
        desk: one to one
        deskquote: one to one
        material one to one
        rushOrder on to one


         */

        public int DeskID { get; set; }
        [StringLength(60, MinimumLength=2)]
        [RegularExpression(@"^[A-Z0-9]+[a-zA-Z0-9""'\s-]*$")]

        [Required]
        public string LastName { get; set; }
        [StringLength(60, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z0-9]+[a-zA-Z0-9""'\s-]*$")]

        [Required]
        public string FirstName { get; set; }
        [Range (24, 96)]
        [Required]
        public int Width { get; set; }
        [Range(12, 48)]
        [Required]
        public int Depth { get; set; }
        [Range (0,7)]
        [Required]
        public int Drawers { get; set; }
        [Required]
        public int RushOrderID { get; set; }
        [Required]
        public int DeskMaterialID { get; set; }

        //Navigation Properties
        public DeskMaterial Material { get; set; }
        public RushOrder RushOrder { get; set; }
        public DeskQuote DeskQuote { get; set; }
        
        
        

        //add validations
        
    }
}
