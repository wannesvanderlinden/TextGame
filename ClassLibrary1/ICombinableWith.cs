﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public interface ICombinableWith<T> where T:Key
    {
        public void UsedWith();
    }
}
