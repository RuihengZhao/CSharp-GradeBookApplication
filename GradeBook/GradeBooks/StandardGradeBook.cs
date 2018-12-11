﻿using GradeBook.Enums;
using System;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(String name) : base(name)
        {
            Type = GradeBookType.Standard;
        }
    }
}