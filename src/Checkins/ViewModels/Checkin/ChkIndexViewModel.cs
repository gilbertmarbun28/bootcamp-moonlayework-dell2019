using System;
using System.Collections.Generic;
using System.Text;

namespace Checkins.ViewModels.Checkin
{
    public class ChkIndexViewModel
    {
        public ChkIndexViewModel(IEnumerable<CheckinDto> data)
        {
            Checkins = data ?? new List<CheckinDto>();
        }

        public IEnumerable<CheckinDto> Checkins { get; }
    }
}
