﻿// Copyright (c) 2018 fit.uet.vnu.edu.vn
// author @vanduong
// created on 12:44 AM 2018/7/3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace ABI.Model.Word
{
    /// <summary>
    /// represent for a border of an object
    /// </summary>
    class ABIW_Border : IComparison
    {
        public static log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private Border border;

        public ABIW_Border(Border border)
        {
            this.border = border;
        }

        public Border Border
        {
            get
            {
                return border;
            }

            set
            {
                 border = value;
            }
        }

        public IComparisonResult Compare(object other)
        {
            if (other is ABIW_Border otherBorder)
            {
                if (border.LineStyle == otherBorder.Border.LineStyle
                    && border.LineWidth == otherBorder.Border.LineWidth
                    && border.Color == otherBorder.Border.Color
                    && border.ColorIndex == otherBorder.Border.ColorIndex
                    && border.Visible == otherBorder.Border.Visible)
                {
                    return new ComparisonResult(ComparisonResultIndicate.equal);
                }
                else
                    return new ComparisonResult(ComparisonResultIndicate.not_equal);
            }
            else
                return new ComparisonResult(ComparisonResultIndicate.not_equal);
        }
    }
}