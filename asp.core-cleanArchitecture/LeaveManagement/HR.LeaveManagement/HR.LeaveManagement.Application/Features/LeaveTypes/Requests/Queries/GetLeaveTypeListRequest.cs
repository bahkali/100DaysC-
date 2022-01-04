﻿using HR.LeaveManagement.Application.DTOs;
using MediatR;
using System.Collections.Generic;


namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDto>>
    {
    }
}
