using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    Id = 1,
                    UserName ="Emre"
                },
                new UserComment
                {
                    Id = 2,
                    UserName ="Can"
                },
                new UserComment
                {
                    Id=3,
                    UserName ="Yasar"
                }
            };
            return View(commentvalues);
        }
    }
}
