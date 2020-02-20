using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectManagmentForm {
	public class Activity {

		protected int _id;
        protected string _name;
        protected string _description;
        protected Date _startDate;
        protected Date _endDate;



        #region Costruttori
        public Activity( int id, string name, string description, Date startDate, Date endDate) {
			_id = id;
			_name = name;
			_description = description;
			_startDate = startDate;
			_endDate = endDate;
		}
        public Activity( int id, string name, string description) : this(id, name, description, Date.Today, Date.Today) { }   
		public Activity( ) : this(0, "", "", Date.Today, Date.Today) { }

        #endregion 




    }

}
