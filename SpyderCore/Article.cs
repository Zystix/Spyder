using System;
using System.Collections.Generic;
using System.Text;

namespace SpyderCore
{

    public struct ArticleData
    {
         public double PerNeg;
         public double PerPos;

        public ArticleData(double PerNeg, double PerPos)
        {
            this.PerNeg = PerNeg;
            this.PerPos = PerPos;
        }


        
    }


    public class Article
    {

        public ArticleData Data;
        public string Title;
        public string Author;
        public string URL;

        public Article()
        {
            Data = new ArticleData();
        }

        
    }
}
