using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using mk866815MIS4200.DAL;
using mk866815MIS4200.Models;

namespace mk866815MIS4200.Controllers
{
    public class GradesController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: Grades
        public ActionResult Index()
        {
            var grade = db.Grade.Include(g => g.Course).Include(g => g.Student);
            return View(grade.ToList());
        }

        // GET: Grades/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grade grade = db.Grade.Find(id);
            if (grade == null)
            {
                return HttpNotFound();
            }
            return View(grade);
        }

        // GET: Grades/Create
        public ActionResult Create()
        {
            ViewBag.courseID = new SelectList(db.Course, "CourseID", "courseName");
            ViewBag.studentID = new SelectList(db.Student, "studentID", "fullName");
            return View();
        }

        // POST: Grades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "gradeID,courseGrade,gradeDate,studentID,courseID")] Grade grade)
        {
            if (ModelState.IsValid)
            {
                db.Grade.Add(grade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.courseID = new SelectList(db.Course, "CourseID", "courseName", grade.courseID);
            ViewBag.studentID = new SelectList(db.Student, "studentID", "firstName", grade.studentID);
            return View(grade);
        }

        // GET: Grades/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grade grade = db.Grade.Find(id);
            if (grade == null)
            {
                return HttpNotFound();
            }
            ViewBag.courseID = new SelectList(db.Course, "CourseID", "courseName", grade.courseID);
            ViewBag.studentID = new SelectList(db.Student, "studentID", "firstName", grade.studentID);
            return View(grade);
        }

        // POST: Grades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "gradeID,courseGrade,gradeDate,studentID,courseID")] Grade grade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(grade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.courseID = new SelectList(db.Course, "CourseID", "courseName", grade.courseID);
            ViewBag.studentID = new SelectList(db.Student, "studentID", "firstName", grade.studentID);
            return View(grade);
        }

        // GET: Grades/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grade grade = db.Grade.Find(id);
            if (grade == null)
            {
                return HttpNotFound();
            }
            return View(grade);
        }

        // POST: Grades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Grade grade = db.Grade.Find(id);
            db.Grade.Remove(grade);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
