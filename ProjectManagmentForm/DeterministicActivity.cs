using System;

namespace ProjectManagmentForm 
{
	class DeterministicActivity : Activity
    {
		private TimeSpan _duration;


        #region Costruttori
        public DeterministicActivity( int id, string name, string description, Date startDate, TimeSpan duration ) 
			: base(id, name, description, startDate, Date.Today) {
			_duration = duration;
            _endDate = _startDate.AddDays(_duration.Days - 1);
		}
        public DeterministicActivity( int id, string name, string description) : this(id, name, description, Date.Today, TimeSpan.Zero) { }
        public DeterministicActivity( ) : base()
        {
			_duration = TimeSpan.Zero;
		}
        #endregion

        
	}

}
