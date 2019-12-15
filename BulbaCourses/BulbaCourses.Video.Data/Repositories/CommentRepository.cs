﻿using BulbaCourses.Video.Data.DatabaseContext;
using BulbaCourses.Video.Data.Interfaces;
using BulbaCourses.Video.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulbaCourses.Video.Data.Repositories
{
    public class CommentRepository : BaseRepository, ICommentRepository
    {

        public CommentRepository(VideoDbContext videoDbContext) : base(videoDbContext)
        {
        }

        public void Add(CommentDb comment)
        {
            _videoDbContext.Comments.Add(comment);
            _videoDbContext.SaveChanges();

        }

        public IEnumerable<CommentDb> GetAll()
        {
            var commentList = _videoDbContext.Comments.ToList().AsReadOnly();
            return commentList;

        }

        public CommentDb GetById(string commentId)
        {
            var comment = _videoDbContext.Comments.FirstOrDefault(b => b.CommentId.Equals(commentId));
            return comment;

        }

        public void Remove(CommentDb comment)
        {
            _videoDbContext.Comments.Remove(comment);
            _videoDbContext.SaveChanges();

        }

        public void Update(CommentDb comment)
        {
            if (comment == null)
            {
                throw new ArgumentNullException("comment");
            }
            _videoDbContext.Entry(comment).State = EntityState.Modified;
            _videoDbContext.SaveChanges();

        }
    }
}
