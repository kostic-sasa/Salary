using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Salary
{
    public partial class Form1 : Form
    {
        private decimal taxDeductionAmount = 11000;
        private decimal workerTaxPercentage = 0.10M;
        private decimal workerPensionPercentage = 0.13M;
        private decimal workerHealthcarePercentage = 0.0615M;
        private decimal workerUnemploymentPercentage = 0.0075M;
        private decimal workerSocialTotalPercentage = 0.199M;

        private decimal employerPensionPercentage = 0.11M;
        private decimal employerHealthcarePercentage = 0.0615M;
        private decimal employerUnemploymentPercentage = 0.0075M;
        private decimal employerSocialTotalPercentage = 0.179M;

        private decimal employerRepublicChamberPercentage = 0.0019M;
        private decimal employerCityChamberPercentage = 0.0029M;
        private decimal employerChamberTotalPercentage = 0.0048M;

        public Form1()
        {
            InitializeComponent();
            workerTaxDeduction.Value = taxDeductionAmount;
            workerIncomeTotalAmount.Value = 138231.09M;
        }

        private void totalIncome_ValueChanged(object sender, EventArgs e)
        {
            workerTaxFee.Value = workerIncomeTotalAmount.Value * workerTaxPercentage;
            workerTaxTotalFee.Value = workerTaxFee.Value - (workerTaxDeduction.Value * workerTaxPercentage);

            workerPensionFee.Value = workerIncomeTotalAmount.Value * workerPensionPercentage;
            workerHealthcareFee.Value = workerIncomeTotalAmount.Value * workerHealthcarePercentage;
            workerUnemploymentFee.Value = workerIncomeTotalAmount.Value * workerUnemploymentPercentage;
            workerSocialTotalFee.Value = workerIncomeTotalAmount.Value * workerSocialTotalPercentage;

            employerPensionFee.Value = workerIncomeTotalAmount.Value * employerPensionPercentage;
            employerHealthcareFee.Value = workerIncomeTotalAmount.Value * employerHealthcarePercentage;
            employerUnemploymentFee.Value = workerIncomeTotalAmount.Value * employerUnemploymentPercentage;
            employerSocialTotalFee.Value = workerIncomeTotalAmount.Value * employerSocialTotalPercentage;

            employerRepublicChamberFee.Value = workerIncomeTotalAmount.Value * employerRepublicChamberPercentage;
            employerCityChamberFee.Value = workerIncomeTotalAmount.Value * employerCityChamberPercentage;
            employerChamberTotalFee.Value = workerIncomeTotalAmount.Value * employerChamberTotalPercentage;

            employerSalaryTotalFund.Value = workerIncomeTotalAmount.Value
                                            //+ workerTaxTotalFee.Value
                                            //+ workerSocialTotalFee.Value
                                            + employerSocialTotalFee.Value
                                            + employerChamberTotalFee.Value;
        }
    }
}
