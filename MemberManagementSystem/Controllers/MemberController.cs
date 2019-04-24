using MemberManagementSystem.Service;
using MemberManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemberManagementSystem.Controllers
{
    public class MemberController : Controller
    {
        MemberService memberService = new MemberService();
        // GET: Member
        public ActionResult Index()
        {
            return View(memberService.GetAllMembers());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Member member)
        {
            memberService.CreateMember(member);
            return RedirectToAction("index");
        }
        public ActionResult Delete(int id)
        {
            memberService.DeleteMember(id);
            return RedirectToAction("index");
        }
        public ActionResult Edit(int id)
        {
            return PartialView(memberService.GetMemberById(id));
        }
        [HttpPost]
        public ActionResult Edit(Member member)
        {
            memberService.EditMember(member);
            return RedirectToAction("index");
        }
    }
}