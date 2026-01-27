CREATE TABLE Batches
(
    BatchId INT IDENTITY(1,1) PRIMARY KEY,
    BatchName VARCHAR(30),
    StartDate DATE,
    DurationInDays INT,
    Remarks VARCHAR(200)
);
INSERT INTO Batches (BatchName, StartDate, DurationInDays, Remarks)
VALUES
('DotNet-Jan', '2026-01-10', 60, 'January morning batch'),
('DotNet-Feb', '2026-02-05', 45, 'January Evening batch');
