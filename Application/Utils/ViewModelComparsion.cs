﻿using WebParking.ViewModels;

namespace WebParking.Utils
{
    public static class ViewModelComparsion
    {
        public static bool Compare(SortViewModel sortViewModel, SortState sortOrder, string fieldName)
        {
            return SortViewModel.ChangeState(sortOrder) == sortViewModel.CurrentState &&
                   sortViewModel.FieldName == fieldName;
        }
    }
}
