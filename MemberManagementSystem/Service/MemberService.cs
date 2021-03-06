﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MemberManagementSystem.Models;

namespace MemberManagementSystem.Service
{
    public class MemberService
    {
        readonly Models.MemberEntities db = new Models.MemberEntities();

        public List<Member> GetAllMembers()
        {
            return db.Member.ToList();
        }
        public Member GetMemberById(int id)
        {   
            var target = db.Member.Find(id);
            return target;
        }
        public void CreateMember(Member member)
        {
            db.Member.Add(member);
            db.SaveChanges();
        }
        public void DeleteMember(int id)
        {
            Member target = db.Member.Find(id);
            db.Member.Remove(target);
            db.SaveChanges();
        }
        public void EditMember(Member member)
        {
            Member target = GetMemberById(member.Id);
            //db.Entry(target).CurrentValues.SetValues(member);
            //Not working. Don't know why.
            target.Name = member.Name;
            target.Age = member.Age;
            target.Address = member.Address;
            target.Tel = member.Tel;
            db.SaveChanges();
        }
    }
}