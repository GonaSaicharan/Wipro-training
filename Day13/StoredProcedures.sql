--PROCEDURE

CREATE TABLE Employee(
Name VARCHAR(50),
Salary INT,
EMPID INT IDENTITY(1,1) PRIMARY KEY,
CreateDate  DATETIME NOT NULL DEFAULT GETDATE());

--USER STORY 1
CREATE PROCEDURE usp_AddEmployee
    @Name VARCHAR(50),
    @Salary INT,
    @EMPID INT OUTPUT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION

        INSERT INTO Employee (Name, Salary)
        VALUES (@Name, @Salary)

        SET @EMPID = SCOPE_IDENTITY()

        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
		ROLLBACK TRANSACTION
        THROW
    END CATCH
END

DECLARE @Id INT
EXEC usp_AddEmployee 'Surya',45000,@ID OUTPUT
SELECT @Id AS NewEmployeeID

select * from Employee;

--USER STORY 2
CREATE PROCEDURE usp_SalaryValidation
	@Name VARCHAR(50),
	@Salary INT,
	@EMPID INT OUTPUT
AS
BEGIN
	BEGIN TRY
		IF @Salary<=0
		BEGIN
			THROW 500001, 'Salary must be greater than Zero.',1;
		END

		BEGIN TRANSACTION;
			INSERT INTO Employee(Name,Salary)
			VALUES(@Name,@Salary)

			SET @EMPID=SCOPE_IDENTITY();

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		THROW
	END CATCH
END;

DECLARE @Id INT
EXEC usp_SalaryValidation 'Anirudh',50000,@Id OUTPUT
SELECT @Id AS NewEmployeeID

DROP PROCEDURE usp_SalaryValidation;
SELECT * FROM Employee;

--USER STORY 3
CREATE PROCEDURE usp_UpdateSalary
	@Name VARCHAR(50),
	@Salary INT,
	@EMPID INT OUTPUT
AS
BEGIN
	BEGIN TRY
		IF @Salary<=0
		BEGIN
			THROW 50002, 'Salary should be greater than zero.',2;
		END

		IF NOT EXISTS(SELECT 1 FROM Employee WHERE EMPID=@EMPID)
		BEGIN	
			THROW 50003, 'Employee does not exists.',3;
		END

		BEGIN TRANSACTION;
			UPDATE Employee
			SET Salary=@Salary
			WHERE EMPID=@EMPID
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
	IF @@TRANCOUNT>0
		ROLLBACK TRANSACTION
	END CATCH
END

DECLARE @Id INT
EXEC usp_AddEmployee @Name='Ajay',@Salary=60000,@EMPID=@Id OUTPUT 
SELECT @Id AS NewEmployeeID

select * FROM Employee;

--USER STORY 5
CREATE PROCEDURE usp_RetrieveEmployee
	@EMPID INT
AS
BEGIN
	IF NOT EXISTS(SELECT 1 FROM Employee WHERE EMPID=@EMPID)
		BEGIN
			THROW 50003, 'Employee does not exists.',3;
		END

		SELECT Name, Salary, EMPID FROM Employee
		WHERE EMPID=@EMPID;
END
drop procedure usp_RetrieveEmployee;


EXEC usp_RetrieveEmployee 3;