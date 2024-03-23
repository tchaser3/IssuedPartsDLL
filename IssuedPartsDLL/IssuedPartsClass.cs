/* Title:           Issued Parts Class
 * Date:            4-28-16
 * Author:          Terry Holmes
 *
 * Description:     This is the Issued Parts Class */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace IssuedPartsDLL
{
    public class IssuedPartsClass
    {
        //setting up the class
        EventLogClass TheEventLogClass = new EventLogClass();

        IssuedPartsDataSet aIssuedPartsDataSet;
        IssuedPartsDataSetTableAdapters.issuedpartsTableAdapter aIssuedPartsTableAdapter;

        InsertIssuedPartsDataTableAdapters.QueriesTableAdapter aInsertIssuedPartsTableAdapter;

        UpdateIssuedPartsQuantityDataTableAdapters.QueriesTableAdapter aUpdateIssuedPartsQuantityTableAdapter;

        FindIssuedPartsByTransactionIDDataSet aFindIssuedPartsByTransactionIDDataSet;
        FindIssuedPartsByTransactionIDDataSetTableAdapters.FindIssuedPartsByTransactionIDTableAdapter aFindIssuedPartsByTransactionIDTableAdapter;

        FindIssuedPartsQuickByTransactionIDDataSet aFindIssuedPartsQuickByTransactionIDDataSet;
        FindIssuedPartsQuickByTransactionIDDataSetTableAdapters.FindIssuedPartsQuickByTransactionIDTableAdapter aFindIssuedPartsQuickByTransactionIDTableAdapter;

        FindIssuedPartsByProjectIDDataSet aFindIssuedPartsByProjectIDDataSet;
        FindIssuedPartsByProjectIDDataSetTableAdapters.FindIssuedPartsByProjectIDTableAdapter aFindIssuedPartsByProjectIDTableAdapter;

        FindIssuedPartsByAssignedProjectIDDataSet aFindIssuedPartsByAssignedProjectIDDataSet;
        FindIssuedPartsByAssignedProjectIDDataSetTableAdapters.FindIssuedPartsByAssignedProjectIDTableAdapter aFindIssuedPartsByAssignedProjectIDTableAdapter;

        FindIssuedPartsByDateRangeDataSet aFindIssuedPartsByDateRangeDataSet;
        FindIssuedPartsByDateRangeDataSetTableAdapters.FindIssuedPartsByDateRangeTableAdapter aFindIssuedPartsByDateRangeTableAdapter;

        FindIssuedPartsByEmployeeIDAndDateRangeDataSet aFindIssuedPartsByEmployeeIDAndDateRangeDateRange;
        FindIssuedPartsByEmployeeIDAndDateRangeDataSetTableAdapters.FindIssuedPartsByEmployeeIDAndDateRangeTableAdapter aFindIssuedPartsByEmployeeIDAndDateRangeTableAdapter;

        FindIssuedPartsByEntryEmployeeIDAndDateRangeDataSet aFindIssuedPartsByEntryEmployeeIDAndDataRangeDataSet;
        FindIssuedPartsByEntryEmployeeIDAndDateRangeDataSetTableAdapters.FindIssuedPartsByEntryEmployeeIDAndDateRangeTableAdapter aFindIssuedPartsByEntryEmployeeIDAndDateRangeTableAdapter;

        FindIssuedPartsByProjectNameDataSet aFindIssuedPartsByProjectNameDataSet;
        FindIssuedPartsByProjectNameDataSetTableAdapters.FindIssuedPartsByProjectNameTableAdapter aFindIssuedPartsByProjectNameTableAdapter;

        FindIssuedPartsByWarehouseIDAndDateRangeDataSet aFindIssuedPartsByWarehouseIDAndDateRangeDataSet;
        FindIssuedPartsByWarehouseIDAndDateRangeDataSetTableAdapters.FindIssuedpartsByWarehouseIDAndDateRangeTableAdapter aFindIssuedPartsByWarehouseIDAndDateRangeTableAdapter;

        FindIssuedPartsByPartIDWarehouseIDAndDateRangeDataSet aFindIssuedPartsByPartIDWarehouseIDAndDateRangeDataSet;
        FindIssuedPartsByPartIDWarehouseIDAndDateRangeDataSetTableAdapters.FindIssuedPartsByPartIDWarehouseIDAndDateRangeTableAdapter aFindIssuedPartsByPartIDWarehouseIDAndDateRangeTableAdapter;

        FindIssuedPartsByTransactionDateDataSet aFindIssuedPartsByTransactionDateDataSet;
        FindIssuedPartsByTransactionDateDataSetTableAdapters.FindIssuedPartsByTransactionDateTableAdapter aFindIssuedPartsByTransactionDateTableAdapter;

        UpdateIssuedPartsProjectIDEntryTableAdapters.QueriesTableAdapter aUpdateIssuedPartsProjectIDTableAdatper;

        public bool UpdateIssuedPartsProjectID(int intTransactionID, int intProjectID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateIssuedPartsProjectIDTableAdatper = new UpdateIssuedPartsProjectIDEntryTableAdapters.QueriesTableAdapter();
                aUpdateIssuedPartsProjectIDTableAdatper.UpdateIssuePartsProjectID(intTransactionID, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Issued Parts Class // Update Issued Parts Project ID " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindIssuedPartsByTransactionDateDataSet FindIssuedPartsByTransactionDate(DateTime datTransactionDate, int intPartID)
        {
            try
            {
                aFindIssuedPartsByTransactionDateDataSet = new FindIssuedPartsByTransactionDateDataSet();
                aFindIssuedPartsByTransactionDateTableAdapter = new FindIssuedPartsByTransactionDateDataSetTableAdapters.FindIssuedPartsByTransactionDateTableAdapter();
                aFindIssuedPartsByTransactionDateTableAdapter.Fill(aFindIssuedPartsByTransactionDateDataSet.FindIssuedPartsByTransactionDate, datTransactionDate, intPartID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Issued Parts Class // Find Issued Parts By Transaction Date " + Ex.Message);
            }

            return aFindIssuedPartsByTransactionDateDataSet;
        }
        public FindIssuedPartsByPartIDWarehouseIDAndDateRangeDataSet FindIssuedPartsByPartIDWarehouseIDDateRange(int intPartID, int intWarehouseID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindIssuedPartsByPartIDWarehouseIDAndDateRangeDataSet = new FindIssuedPartsByPartIDWarehouseIDAndDateRangeDataSet();
                aFindIssuedPartsByPartIDWarehouseIDAndDateRangeTableAdapter = new FindIssuedPartsByPartIDWarehouseIDAndDateRangeDataSetTableAdapters.FindIssuedPartsByPartIDWarehouseIDAndDateRangeTableAdapter();
                aFindIssuedPartsByPartIDWarehouseIDAndDateRangeTableAdapter.Fill(aFindIssuedPartsByPartIDWarehouseIDAndDateRangeDataSet.FindIssuedPartsByPartIDWarehouseIDAndDateRange, intPartID, intWarehouseID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Issued Parts Class // Find Issued Parts By Part ID Warehouse ID Date Range " + Ex.Message);
            }

            return aFindIssuedPartsByPartIDWarehouseIDAndDateRangeDataSet;
        }
        public FindIssuedPartsByWarehouseIDAndDateRangeDataSet FindIssuedPartsByWarehouseIDAndDateRange(int intWarehouseID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindIssuedPartsByWarehouseIDAndDateRangeDataSet = new FindIssuedPartsByWarehouseIDAndDateRangeDataSet();
                aFindIssuedPartsByWarehouseIDAndDateRangeTableAdapter = new FindIssuedPartsByWarehouseIDAndDateRangeDataSetTableAdapters.FindIssuedpartsByWarehouseIDAndDateRangeTableAdapter();
                aFindIssuedPartsByWarehouseIDAndDateRangeTableAdapter.Fill(aFindIssuedPartsByWarehouseIDAndDateRangeDataSet.FindIssuedpartsByWarehouseIDAndDateRange, intWarehouseID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Issued Parts Class // Find Issued Parts By Warehouse ID and Date Range " + Ex.Message);
            }

            return aFindIssuedPartsByWarehouseIDAndDateRangeDataSet;
        }
        public FindIssuedPartsByProjectNameDataSet FindIssuedPartsByProjectName(string strProjectName)
        {
            try
            {
                aFindIssuedPartsByProjectNameDataSet = new FindIssuedPartsByProjectNameDataSet();
                aFindIssuedPartsByProjectNameTableAdapter = new FindIssuedPartsByProjectNameDataSetTableAdapters.FindIssuedPartsByProjectNameTableAdapter();
                aFindIssuedPartsByProjectNameTableAdapter.Fill(aFindIssuedPartsByProjectNameDataSet.FindIssuedPartsByProjectName, strProjectName);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Issued Parts Class // Find Issued By Project Name " + Ex.Message);
            }

            return aFindIssuedPartsByProjectNameDataSet;
        }
        public FindIssuedPartsByEntryEmployeeIDAndDateRangeDataSet FindIssuedPartsByEntryEmployeeIDAndDateRange(int intEntryEmployeeID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindIssuedPartsByEntryEmployeeIDAndDataRangeDataSet = new FindIssuedPartsByEntryEmployeeIDAndDateRangeDataSet();
                aFindIssuedPartsByEntryEmployeeIDAndDateRangeTableAdapter = new FindIssuedPartsByEntryEmployeeIDAndDateRangeDataSetTableAdapters.FindIssuedPartsByEntryEmployeeIDAndDateRangeTableAdapter();
                aFindIssuedPartsByEntryEmployeeIDAndDateRangeTableAdapter.Fill(aFindIssuedPartsByEntryEmployeeIDAndDataRangeDataSet.FindIssuedPartsByEntryEmployeeIDAndDateRange, intEntryEmployeeID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Issued Parts Class // Find Issued Parts By Entry Employee ID and Date Range " + Ex.Message);
            }

            return aFindIssuedPartsByEntryEmployeeIDAndDataRangeDataSet;
        }
        public FindIssuedPartsByEmployeeIDAndDateRangeDataSet FindIssuedPartsByEmployeeIDAndDateRange(int intEmployeeID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindIssuedPartsByEmployeeIDAndDateRangeDateRange = new FindIssuedPartsByEmployeeIDAndDateRangeDataSet();
                aFindIssuedPartsByEmployeeIDAndDateRangeTableAdapter = new FindIssuedPartsByEmployeeIDAndDateRangeDataSetTableAdapters.FindIssuedPartsByEmployeeIDAndDateRangeTableAdapter();
                aFindIssuedPartsByEmployeeIDAndDateRangeTableAdapter.Fill(aFindIssuedPartsByEmployeeIDAndDateRangeDateRange.FindIssuedPartsByEmployeeIDAndDateRange, intEmployeeID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Issued Parts Class // Find Issued Parts By Employee ID and Date Range " + Ex.Message);
            }

            return aFindIssuedPartsByEmployeeIDAndDateRangeDateRange;
        }
        public FindIssuedPartsByDateRangeDataSet FindIssuedPartsByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindIssuedPartsByDateRangeDataSet = new FindIssuedPartsByDateRangeDataSet();
                aFindIssuedPartsByDateRangeTableAdapter = new FindIssuedPartsByDateRangeDataSetTableAdapters.FindIssuedPartsByDateRangeTableAdapter();
                aFindIssuedPartsByDateRangeTableAdapter.Fill(aFindIssuedPartsByDateRangeDataSet.FindIssuedPartsByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Issued Parts Class // Find Issued Parts By Date Range " + Ex.Message);
            }

            return aFindIssuedPartsByDateRangeDataSet;
        }
        public FindIssuedPartsByAssignedProjectIDDataSet FindIssuedPartsByAssignedProjectID(string strAssignedProjectID)
        {
            try
            {
                aFindIssuedPartsByAssignedProjectIDDataSet = new FindIssuedPartsByAssignedProjectIDDataSet();
                aFindIssuedPartsByAssignedProjectIDTableAdapter = new FindIssuedPartsByAssignedProjectIDDataSetTableAdapters.FindIssuedPartsByAssignedProjectIDTableAdapter();
                aFindIssuedPartsByAssignedProjectIDTableAdapter.Fill(aFindIssuedPartsByAssignedProjectIDDataSet.FindIssuedPartsByAssignedProjectID, strAssignedProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Issued Parts Class // Find Issued Parts Assigned Project ID " + Ex.Message);
            }

            return aFindIssuedPartsByAssignedProjectIDDataSet;
        }
        public FindIssuedPartsByProjectIDDataSet FindIssuedPartsByProjectID(int intProjectID)
        {
            try
            {
                aFindIssuedPartsByProjectIDDataSet = new FindIssuedPartsByProjectIDDataSet();
                aFindIssuedPartsByProjectIDTableAdapter = new FindIssuedPartsByProjectIDDataSetTableAdapters.FindIssuedPartsByProjectIDTableAdapter();
                aFindIssuedPartsByProjectIDTableAdapter.Fill(aFindIssuedPartsByProjectIDDataSet.FindIssuedPartsByProjectID, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Issued Parts Class // Find Issued Parts By Project ID " + Ex.Message);
            }

            return aFindIssuedPartsByProjectIDDataSet;
        }
        public FindIssuedPartsQuickByTransactionIDDataSet FindIssuedPartsQuickByTransactionID(int intTransactionID)
        {
            try
            {
                aFindIssuedPartsQuickByTransactionIDDataSet = new FindIssuedPartsQuickByTransactionIDDataSet();
                aFindIssuedPartsQuickByTransactionIDTableAdapter = new FindIssuedPartsQuickByTransactionIDDataSetTableAdapters.FindIssuedPartsQuickByTransactionIDTableAdapter();
                aFindIssuedPartsQuickByTransactionIDTableAdapter.Fill(aFindIssuedPartsQuickByTransactionIDDataSet.FindIssuedPartsQuickByTransactionID, intTransactionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Issued Part Class // Find Issued Parts Quick By Transaction ID " + Ex.Message);
            }

            return aFindIssuedPartsQuickByTransactionIDDataSet;
        }
        public FindIssuedPartsByTransactionIDDataSet FindIssuedPartsByTransactionID(int intTransactionID)
        {
            try
            {
                aFindIssuedPartsByTransactionIDDataSet = new FindIssuedPartsByTransactionIDDataSet();
                aFindIssuedPartsByTransactionIDTableAdapter = new FindIssuedPartsByTransactionIDDataSetTableAdapters.FindIssuedPartsByTransactionIDTableAdapter();
                aFindIssuedPartsByTransactionIDTableAdapter.Fill(aFindIssuedPartsByTransactionIDDataSet.FindIssuedPartsByTransactionID, intTransactionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Issued Parts Class // Find Issued Parts By Transaction ID " + Ex.Message);
            }

            return aFindIssuedPartsByTransactionIDDataSet;
        }
        public bool UpdateIssuedParts(int intTransactionID, int intQuantity)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateIssuedPartsQuantityTableAdapter = new UpdateIssuedPartsQuantityDataTableAdapters.QueriesTableAdapter();
                aUpdateIssuedPartsQuantityTableAdapter.UpdateIssuedPartsQuantity(intTransactionID, intQuantity);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Issued Parts Class // Update Issued Parts " + Ex.Message);
            }

            return blnFatalError;
        }
        public bool InsertIssuedParts(int intProjectID, int intPartID, int intQuantity, int intEmployeeID, int intEntryEmployeeID, int intWarehouseID)
        {
            bool blnFatalError = false;
            
            try
            {
                aInsertIssuedPartsTableAdapter = new InsertIssuedPartsDataTableAdapters.QueriesTableAdapter();
                aInsertIssuedPartsTableAdapter.InsertIssuedParts(DateTime.Now, intProjectID, intPartID, intQuantity, intEmployeeID, intEntryEmployeeID, intWarehouseID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Issued Parts Class // Insert Issued Parts " + Ex.Message);
            }

            return blnFatalError;
        }
        public IssuedPartsDataSet GetIssuedPartsInfo()        //method to fill the data set
        {
            try
            {
                //fill data set
                aIssuedPartsDataSet = new IssuedPartsDataSet();
                aIssuedPartsTableAdapter = new IssuedPartsDataSetTableAdapters.issuedpartsTableAdapter();
                aIssuedPartsTableAdapter.Fill(aIssuedPartsDataSet.issuedparts);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now,"Issued Parts Class // Get Issued Parts Info " + Ex.Message);
            }

            //returing value
            return aIssuedPartsDataSet;
        }
        public void UpdateIssuedPartsDB(IssuedPartsDataSet aIssuedPartsDataSet)
        {
            try
            {
                //updating data set
                aIssuedPartsTableAdapter = new IssuedPartsDataSetTableAdapters.issuedpartsTableAdapter();
                aIssuedPartsTableAdapter.Update(aIssuedPartsDataSet.issuedparts);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Issued Parts Class // Update Issued Parts DB " + Ex.Message);
            }
        }
    }
}
