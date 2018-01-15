using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wahventory.classes
{
    class Depreciation
    {

        private double cost = 0.00;
        private double salvageValue = 0.00;
        private int lifespan = 0;
        private String dateProcured = null;

        private double total = 0.00;
        private double depreciation = 0.00;
        private double percentage = 0.00;

        public Depreciation(double cost, double salvageValue, int lifespan, string dateProcured)
        {
            this.cost = cost;
            this.salvageValue = salvageValue;
            this.lifespan = lifespan;
            this.dateProcured = dateProcured;
            setTotal();
            setDepreciation();
            setPercentage();
        }

        private void setTotal(){
            this.total = (cost - salvageValue);
        }

        public double getTotal()
        {
            return this.total;
        }

        private void setDepreciation()
        {
            this.depreciation = (total / (double) lifespan);
        }

        public double getDepreciation()
        {
            return this.depreciation;
        }

        private void setPercentage()
        {
            this.percentage = (1 / (double) lifespan) * 100;   
        }

        public double getPercentage()
        {
            return this.percentage;
        }

        private double getAccumulate(int year)
        {
            return year * depreciation;
        }

        private int getElapseYear(String date)
        {
            DateTime end = DateTime.Now;
            DateTime dateProcured = Convert.ToDateTime(date);
            return (end.Year - dateProcured.Year - 1) +
                (((end.Month > dateProcured.Month) ||
                ((end.Month == dateProcured.Month) && (end.Day >= dateProcured.Day))) ? 1 : 0);
        }

        public System.Data.DataTable getBookValues()
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("Year",typeof(Int32));
            table.Columns.Add("BookValue",typeof(String));

            int year = getYearsBeetween();

            if (year > 0)
            {
                for (int y = 1; y <= year; y++)
                {
                    double accumulate = getAccumulate(y);
                    double bookValue = cost - accumulate;
                    if (bookValue <= 0)
                        break;

                    table.Rows.Add(y, Format.formatToPeso(bookValue));
                }
            }

            return table;
        }


        public int getYearsBeetween()
        {
            return getElapseYear(dateProcured);
        }

        public double getCurrentBookValue()
        {
            double accumulate = getAccumulate(getYearsBeetween());
            return cost - accumulate;
        }






        public static double getCurrentBookValue(String date, double cost, double depreciation)
        {
            DateTime end = DateTime.Now;
            DateTime dateProcured = Convert.ToDateTime(date);
            int year = (end.Year - dateProcured.Year - 1) +
                (((end.Month > dateProcured.Month) ||
                ((end.Month == dateProcured.Month) && (end.Day >= dateProcured.Day))) ? 1 : 0);
            return cost - (year * depreciation);
        }








    }
}
