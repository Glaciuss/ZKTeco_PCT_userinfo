Use CarService
Go

--If Exists (Select Name From SYSOBJECTS Where Type = 'P' and Name = 'usp_AD001_01' ) 
--Drop Procedure usp_AD001_01
--Go

alter Procedure usp_AD001_01
	@CompanyID nvarchar(5),
	@EmployeeID nvarchar(20),
	@EmployeeName nvarchar(80),
	@UserGroupID nvarchar(10),
	@UserStatus smallint,
	@UserName nvarchar(20)
	
As
Begin
 
/* Description: Stored Procedure for 

 ================================================
 [History ]
 Revision No.	1.0
 Create By:		Passakorn 
 Create Date:	2016-05-05
 Modify By:		Passakorn
 Modify Date:	2016-05-05
 Comment:		usp_AD001_01 (User Accout List)

 ================================================
*/

Set NoCount On

-- usp_AD001_01 '01','','','','piyaporn'
	
	SELECT 
		u.CompanyID,
		c.CompanyEnName,
		u.UserName, 
	    u.[Password], 
	    --u.LastLoginTime, ,
		u.PwdNeverExpire,
		u.PwdDayPeriod,
	    u.PasswordSetDate, 
		u.UserGroupID,
		g.UserGroupName,
		u.EmployeeID,
		e.EmployeeName,
		e.EmployeeSurname,
		e.NickName,
		es.EmpStatusName,
		u.AllowCostPrice, 
		u.AllowSalePrice, 
		u.AllowDiscountAmount,
		u.AllowOverDiscount, 
		--u.UserStatus,
		s.UserStatusName as UserStatus,
		u.IsLocked
		--u.IsFirstTime
		
	FROM [User] u
		INNER JOIN [Company] c ON u.CompanyID = c.CompanyID
		INNER JOIN UserGroup g ON g.UserGroupID = u.UserGroupID
        INNER JOIN UserStatus s ON s.UserStatus = u.UserStatus			
		LEFT JOIN [Employee] e ON u.EmployeeID = e.EmployeeID					
		LEFT JOIN [EmpStatus] es ON e.EmpStatusID = es.EmpStatusID
							
	WHERE u.CompanyID = @CompanyID
	AND	u.EmployeeID LIKE '%' + @EmployeeID + '%'
	--AND e.EmpStatusID IN(0,1)
	AND	(isnull(e.EmployeeName,'') LIKE '%' + @EmployeeName + '%' OR
		isnull(e.EmployeeSurname,'') LIKE '%' + @EmployeeName + '%' OR
		isnull(e.EmployeeEName,'') LIKE '%' + @EmployeeName + '%' OR
		isnull(e.EmployeeESurname,'') LIKE '%' + @EmployeeName + '%' )

	AND	u.UserGroupID LIKE @UserGroupID + '%'
	AND	u.UserName LIKE '%' + @UserName + '%'
	AND u.UserStatus = @UserStatus
	
	ORDER BY u.UserName
		

/* ---------- End of Query Script ---------- */
Return
End
Go
