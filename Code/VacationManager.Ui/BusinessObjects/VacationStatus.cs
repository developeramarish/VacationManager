﻿using System;
using Csla;
using VacationManager.Common.ServiceContracts;

namespace VacationManager.Ui.BusinessObjects
{
    [Serializable]
    public class VacationStatus : BusinessBase<VacationStatus>
    {
        #region Private fields

        private int _totalNumber;
        private int _taken;
        private int _left;

        #endregion

        #region Property definitions

        public static PropertyInfo<int> TotalNumberProperty =
            RegisterProperty<int>(c => c.TotalNumber, RelationshipTypes.PrivateField);

        public static PropertyInfo<int> TakenProperty =
            RegisterProperty<int>(c => c.Taken, RelationshipTypes.PrivateField);

        public static PropertyInfo<int> LeftProperty =
            RegisterProperty<int>(c => c.Left, RelationshipTypes.PrivateField);

        #endregion

        #region Public properties

        public int TotalNumber
        {
            get { return GetProperty(TotalNumberProperty, _totalNumber); }
        }

        public int Taken
        {
            get { return GetProperty(TakenProperty, _taken); }
        }

        public int Left
        {
            get { return GetProperty(LeftProperty, _left); }
        }

        #endregion

        #region DataPortal_XYZ methods

        protected void DataPortal_Fetch(long employeeId)
        {
            using (var proxy = new ServiceProxy<IVacationStatusService>(Configuration.ServiceAddress))
            {
                var createdServiceObject = proxy.GetChannel().GetVacationStatusByEmployeeId(employeeId);

                _totalNumber = createdServiceObject.TotalNumber;
                _taken = createdServiceObject.Taken;
                _left = createdServiceObject.Left;
            }
        }

        #endregion
    }
}