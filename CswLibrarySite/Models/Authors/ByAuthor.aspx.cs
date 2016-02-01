﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using CswLibrarySite.CswBookAPI;

namespace CswLibrarySite.Models.Authors
{
    public partial class ByAuthor : System.Web.UI.Page
    {

        public class BooksListJsonResult
        {

            public int BookID { get; set; }
            public string CodeBar { get; set; }      // EAN / UPC
            public string Title { get; set; }        // Title of the book.
            public decimal Price { get; set; }       // Price of the book.
            public string Description { get; set; }      // Description of the book
            public int CategoryID { get; set; }
            public int AuthorID { get; set; }
            public string CategoryName { get; set; }
            public string Name { get; set; }

        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            CswBookAPI.CswBookAPI webService = new CswBookAPI.CswBookAPI();
            //Console.WriteLine(webService.GetAllBooksAsync());
            //Console.ReadLine();
            //System.Diagnostics.Debug.Write(webService.GetBooksByAuthorAsync("1"));
            //var result = JsonConvert.DeserializeObject<List<BooksListJsonResult>>(webService.GetAllBooksAsync());
            //dataGridView.DataSource = result;
        }
    }
}