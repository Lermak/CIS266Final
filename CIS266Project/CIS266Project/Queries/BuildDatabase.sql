DROP TABLE Projects
GO
DROP TABLE Employees
GO
DROP TABLE LuStatus
GO
CREATE TABLE Employees
(
	EmployeeID		INT			IDENTITY PRIMARY KEY,
	FirstName		VARCHAR(30)	NOT NULL,
	LastName		VARCHAR(30)	NOT NULL,
	Title			VARCHAR(30)	NOT NULL
)
GO

CREATE TABLE LuStatus
(
	StatusID	INT			IDENTITY PRIMARY KEY,
	StatusName	VARCHAR(10)	NOT NULL UNIQUE,
	CONSTRAINT chk_Name CHECK(StatusName IN ('Pending', 'Underway', 'Delayed', 'Completed'))
)
GO

CREATE TABLE Projects
(
	ProjectID		INT			IDENTITY PRIMARY KEY,
	ProjectName		VARCHAR(50)	NOT NULL,
	ProjectManager	INT		NOT NULL		FOREIGN KEY REFERENCES Employees(EmployeeID),
	ProjectStatus	INT		NOT NULL	FOREIGN KEY REFERENCES LuStatus(StatusID),
	Desciption		VARCHAR(255)	 NULL,
	ProjectStart	DATE	NOT NULL,
	ProjectEnd		DATE	NULL,

	CONSTRAINT chk_EndDate CHECK(ProjectEnd > ProjectStart)
)
GO

CREATE TABLE Tasks
(
	TaskID				Int			IDENTITY	Primary Key,
	ProjectID			Int			Foreign Key References Tasks(TaskID)	NOT NULL,
	TaskName			VarChar(50)		NOT NULL,
	TaskDescription		VarChar(255)	NULL,	
	StartDate			Date			NOT NULL,	
	EndDate				Date			NULL,
	TaskStatus			Int			Foreign Key References LuStatus(StatusID) NOT NULL,
	CONSTRAINT chk_TaskEndDate CHECK(EndDate > StartDate)

)
GO

CREATE TABLE EmployeeWork
(
	TaskID			Int		NOT NULL	Foreign Key References Tasks(TaskID),
	EmployeeID		Int		NOT NULL	Foreign Key References Employees(EmployeeID),
	WorkDate		Date	NOT NULL,
	WorkHours		Decimal(3,1)	NOT NULL,
	CONSTRAINT chk_Hours CHECK(WorkHours > 0 AND WorkHours <= 24)
)
GO