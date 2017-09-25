using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LukesBlog.DataAccessLayer.Models
{
    public class BlogPost
    {
        public int ID { get; set; }
        public DateTime DatePosted { get; set; }
        [MaxLength(250)]
        public string Title { get; set; }
        [AllowHtml]
        [MaxLength(4000)]
        public string Body { get; set; }
        [MaxLength(250)]
        public string Author { get; set; }
        public int Likes { get; set; }
        public bool Authored { get; set; }

        [MaxLength(20)]
        public string tag1 { get; set; }
        [MaxLength(20)]
        public string tag2 { get; set; }
        [MaxLength(20)]
        public string tag3 { get; set; }

        [MaxLength(200)]
        public string imgsrc { get; set; }

        public List<Comment> Comments { get; set; }

        public override string ToString()
        {
            return String.Format("ID: {0},  \nDate: {1}, \nTitle: {2}, \nAuthor: {3}, \nLikes: {4}\n\n", 
                this.ID, 
                this.DatePosted, 
                this.Title, 
                this.Author, 
                this.Likes
                );
        }

        public string ToHTMLBlogPost()
        {
            string formateddate = string.Format(new CustomDateFormatProvider(), "{0}", this.DatePosted);

            string output = $@"
    
    <div class='post'>
        <h1>{this.Title}</h1>
        <div class='details'>
            <div class='tinygraphic'>
                <svg width='30' height='5'>
                    <rect width='30' height='5'></rect>
                        Sorry, your browser does not support inline SVG.
                </svg>
            </div>
            <div class='date'>{formateddate}</div>
            <div class='tags'>
                <svg width='10' height='10'>
                    <circle cx='5' cy='5' r='4' />
                    Sorry, your browser does not support inline SVG.
                </svg>
                <div class='tag1'>{this.tag1} </div>
                <svg width='10' height='10'>
                    <circle cx='5' cy='5' r='4' />
                    Sorry, your browser does not support inline SVG.
                </svg>
                <div class='tag2'>{this.tag2} </div>
                <svg width='10' height='10'>
                    <circle cx='5' cy='5' r='4' />
                    Sorry, your browser does not support inline SVG.
                </svg>
                <div class='tag3'>{this.tag3} </div>
            </div>
            <div class='tinygraphic'>
                <svg width='30' height='5'>
                    <rect width='30' height='5'></rect>
                        Sorry, your browser does not support inline SVG.
                </svg>
            </div>
        </div>
        <div class='lvcontent'>
            <img src='{this.imgsrc}' alt='Good Times' height='100' width='194' class='rightimg'>
            <span>
                {this.Body}
            </span>
        </div>
    </div>

";
            return output;
        }
    }

    public class Comment
    {
        public int ID { get; set; }
        public DateTime DatePosted { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public int Likes { get; set; }

        public int BlogPostID { get; set; }
        public BlogPost CurrentBlogPost { get; set; }
        
    }


}