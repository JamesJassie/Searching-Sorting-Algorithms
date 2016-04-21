using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmAss1
{
    class SearchAlgorithms
    {
        //The class contains differing search algorithms based on Lists using DateTime or String Days
        public SearchAlgorithms()
        {
                //constructor - not needed
        }
        //---------------------------------------------------------------------------------------------
        #region search date
        /// <summary>
        /// This method will search the given list of records for matching dates and return a match or a 'did not match' result in a list
        /// </summary>
        public List<StoredData> searchByDateA1(List<StoredData> sortedListToSearchA1, DateTime dateToFind)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to search the data
            //#####################################################################################################
            //Place your first search algorithm below here - the results must be in the List 'searchResults'
            //This will be displayed on the left-hand-side of the console window
            //#####################################################################################################
            List<StoredData> searchResults = new List<StoredData>();
            for (int i = 0; i < sortedListToSearchA1.Count; i++)
            {
                countOfRepetitions++;
                if (dateToFind == sortedListToSearchA1[i].TxDate)
                {
                    searchResults.Add(sortedListToSearchA1[i]);
                    break;
                }
            }

                //#####################################################################################################
                //Place your first search algorithm above here - the results must be in the List 'searchResults'
                //#####################################################################################################
                // *** your search result data should be placed in 'searchResults' 
                searchResults.First().SearchTypeAndTime = "Using 'DateSearchAlg1' search by date";//rewrite the text to show user which algorithm you have used
            // place your total count of loops (countOfRepetitions) here
            searchResults.First().CountRepetitions = countOfRepetitions; //rewrite to show user the number of steps (loops) this algorithm has made to sort the data
            return searchResults;
        }
        //**********************************************************************************************
        /// <summary>
        /// This method will search the given list of records for matching dates and return a match or a 'did not match' result in a list
        /// </summary>
        public List<StoredData> searchByDateA2(List<StoredData> sortedListToSearchA2, DateTime dateToFind)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to search the data
            //#####################################################################################################
            //Place your second search algorithm below here - the results must be in the List 'searchResults'
            //This will be displayed on the right-hand-side of the console window
            //#####################################################################################################
            List<StoredData> searchResults = new List<StoredData>();
            int firstIndex = 0;
            int lastIndex = sortedListToSearchA2.Count;
            int midPointIndex = (firstIndex + lastIndex) / 2;

            while (firstIndex < midPointIndex && lastIndex > midPointIndex)
            {
                countOfRepetitions++;
                if (dateToFind == sortedListToSearchA2[midPointIndex].TxDate)
                {
                    searchResults.Add(sortedListToSearchA2[midPointIndex]);
                    break;
                }
                else if (dateToFind > sortedListToSearchA2[midPointIndex].TxDate)
                {
                    lastIndex = midPointIndex;
                    midPointIndex = (firstIndex + lastIndex) / 2;
                }
                else if (dateToFind < sortedListToSearchA2[midPointIndex].TxDate)
                {
                    firstIndex = midPointIndex;
                    midPointIndex = (firstIndex + lastIndex) / 2;
                }
            }
            //#####################################################################################################
            //Place your second search algorithm above here - the results must be in the List 'searchResults'
            //#####################################################################################################
            // *** your search result data should be placed in 'searchResults' 
            searchResults.First().SearchTypeAndTime = "Using 'DateSearchAlg2' search by date";//rewrite the text to show user which algorithm you have used
            // place your total count of loops (countOfRepetitions) here
            searchResults.First().CountRepetitions = countOfRepetitions; //rewrite to show user the number of steps (loops) this algorithm has made to sort the data
            return searchResults;
        }
        #endregion search date
        #region search day
        //**********************************************************************************************
        /// <summary>
        /// This method will search the given list of records for matching days and return a match or a 'did not match' result in a list
        /// </summary>
        public List<StoredData> searchByDayA1(List<StoredData> dataToSearchA1, string dayToFind)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to search the data
            //#####################################################################################################
            //Place your first search algorithm below here - the results must be in the List 'searchResults'
            //This will be displayed on the left-hand-side of the console window
            //#####################################################################################################
            //Create a blank data item to indicate the searched for date doesnot exist in the data set
           
            List<StoredData> searchResults = new List<StoredData>();
            dataToSearchA1.Sort(delegate(StoredData d1, StoredData d2)
            {
                return d1.TxDay.CompareTo(d2.TxDay);
            }
            );
            for (int i = 0; i < dataToSearchA1.Count; i++)
            {
                countOfRepetitions++;
                if (dayToFind == dataToSearchA1[i].TxDay)
                {
                    searchResults.Add(dataToSearchA1[i]);
                }
            }
            //#####################################################################################################
            //Place your first search algorithm below here - the results must be in the List 'searchResults'
            //#####################################################################################################
            // *** your search result data should be placed in 'searchResults' 
            searchResults.First().SearchTypeAndTime = "Using 'DaySearchAlg1' search by day";//rewrite the text to show user which algorithm you have used
            // place your total count of loops (countOfRepetitions) here
            searchResults.First().CountRepetitions = countOfRepetitions; //rewrite to show user the number of steps (loops) this algorithm has made to sort the data
            return searchResults;
        }
        //**********************************************************************************************
        /// <summary>
        /// This method will search the given list of records for matching days and return a match or a 'did not match' result in a list
        /// </summary>
        public List<StoredData> searchByDayA2(List<StoredData> dataToSearchA2, string dayToFind)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to search the data
            //#####################################################################################################
            //Place your second search algorithm below here - the results must be in the List 'searchResults'
            //This will be displayed on the right-hand-side of the console window
            //#####################################################################################################
            //Create a blank data item to indicate the searched for date doesnot exist in the data set
            List<StoredData> searchResults = new List<StoredData>();
            dataToSearchA2.Sort(delegate(StoredData d1, StoredData d2)
            {
                return d2.TxDay.CompareTo(d1.TxDay);
            }
            );
            for (int i = 0; i < dataToSearchA2.Count; i++)
            {
                countOfRepetitions++;
                if (dayToFind == dataToSearchA2[i].TxDay)
                {
                    searchResults.Add(dataToSearchA2[i]);
                }
            }

            //#####################################################################################################
            //Place your second search algorithm below here - the results must be in the List 'searchResults'
            //#####################################################################################################
            // *** your search result data should be placed in 'searchResults' 
            searchResults.First().SearchTypeAndTime = "Using 'DaySearchAlg2' search by day";//rewrite the text to show user which algorithm you have used
            // place your total count of loops (countOfRepetitions) here
            searchResults.First().CountRepetitions = countOfRepetitions; //rewrite to show user the number of steps (loops) this algorithm has made to sort the data
            
            return searchResults;
        }
        //**********************************************************************************************
        #endregion search day
    }   
}
