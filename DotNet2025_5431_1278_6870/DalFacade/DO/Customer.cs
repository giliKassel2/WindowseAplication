﻿

namespace DO
{
    /// :אובייקט לקוח המכיל את התכונות
    /// תעודת זהות
    /// שם הלקוח
    /// כתובת
    /// טלפון
   public record Customer
        (int Id,
        string Name,
        string? Adress,
        string? PhoneNumber)
    {
        public Customer(): this(0,"","","")
        {
            
        }
    }
}
