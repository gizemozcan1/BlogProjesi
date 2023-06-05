using GizemBlog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GizemBlog.ViewComponents
{
	public class CommentList:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>
			{
				new UserComment
				{
					 ID= 1,
					 Username="Gizem"
				},
				new UserComment
				{
					ID= 2,
					Username="Mesut"
				},
				new UserComment
				{
					ID= 3,
					Username="Merve"
				}
			};
			return View(commentvalues);
		}
	}
}
