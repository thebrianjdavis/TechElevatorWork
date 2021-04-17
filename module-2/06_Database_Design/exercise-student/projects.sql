USE master;
GO

DROP DATABASE IF EXISTS ProjectOrganizer

CREATE DATABASE ProjectOrganizer;
GO

USE ProjectOrganizer
GO

BEGIN TRANSACTION;

CREATE TABLE employee
(
	employee_id			int				identity(1,1),
	job_title			varchar(255)	NOT NULL,
	last_name			varchar(255)	NOT NULL,
	first_name			varchar(255)	NOT NULL,
	gender				varchar(255),
	date_of_birth		datetime		NOT NULL,
	date_of_hire		datetime		NOT NULL,

	CONSTRAINT pk_employee PRIMARY KEY (employee_id)
);

CREATE TABLE department
(
	department_id		int				identity(1,1),
	name				varchar(255)	NOT NULL,

	CONSTRAINT pk_department PRIMARY KEY (department_id)
);

CREATE TABLE employee_department
(
	employee_id			int,
	department_id		int

	CONSTRAINT pk_employee_department PRIMARY KEY (employee_id, department_id),
	CONSTRAINT fk_ed_employee FOREIGN KEY (employee_id) REFERENCES employee (employee_id),
	CONSTRAINT fk_ed_project FOREIGN KEY (department_id) REFERENCES department (department_id)
);

CREATE TABLE project
(
	project_id			int				identity(1,1),
	name				varchar(255)	NOT NULL,
	start_date			datetime		NOT NULL

	CONSTRAINT pk_project PRIMARY KEY (project_id)
);

CREATE TABLE employee_project
(
	employee_id			int,
	project_id			int

	CONSTRAINT pk_employee_project PRIMARY KEY (employee_id, project_id),
	CONSTRAINT fk_ep_employee FOREIGN KEY (employee_id) REFERENCES employee (employee_id),
	CONSTRAINT fk_ep_project FOREIGN KEY (project_id) REFERENCES project (project_id)
);

INSERT INTO employee (job_title, last_name, first_name, gender, date_of_birth, date_of_hire)
VALUES ('CEO', 'Dudeman', 'Guy', 'female', '1971-06-09', '2021-01-01');

INSERT INTO employee (job_title, last_name, first_name, gender, date_of_birth, date_of_hire)
VALUES ('CTO', 'Immalady', 'Jennifer', 'male', '1976-02-29', '2021-01-01');

INSERT INTO employee (job_title, last_name, first_name, gender, date_of_birth, date_of_hire)
VALUES ('Salesperson', 'Awesome', 'Gal', 'female', '1986-12-05', '2021-02-01');

INSERT INTO employee (job_title, last_name, first_name, gender, date_of_birth, date_of_hire)
VALUES ('Salesperson', 'Friendly', 'Friend', 'male', '1980-11-16', '2021-01-01');

INSERT INTO employee (job_title, last_name, first_name, gender, date_of_birth, date_of_hire)
VALUES ('Senior Developer', 'Downmuhneck', 'Breathes', 'male', '1987-05-19', '2021-02-01');

INSERT INTO employee (job_title, last_name, first_name, gender, date_of_birth, date_of_hire)
VALUES ('Junior Developer', 'Davis', 'Brian', 'male', '1984-04-19', '2021-02-01');

INSERT INTO employee (job_title, last_name, first_name, gender, date_of_birth, date_of_hire)
VALUES ('Junior Developer', 'Sanchez', 'Ricky', 'male', '1988-08-08', '2021-02-01');

INSERT INTO employee (job_title, last_name, first_name, gender, date_of_birth, date_of_hire)
VALUES ('Junior Developer', 'California', 'Roberta', 'female', '1989-12-07', '2021-02-01');

INSERT INTO department (name)
VALUES ('Corporate');

INSERT INTO department (name)
VALUES ('Sales');

INSERT INTO department (name)
VALUES ('Development');

INSERT INTO project (name, start_date)
VALUES ('VR Dieting', '2021-02-01');

INSERT INTO project (name, start_date)
VALUES ('Sleeping While Looking Awake', '2021-02-01');

INSERT INTO project (name, start_date)
VALUES ('Thought Powered Interface', '2021-02-01');

INSERT INTO project (name, start_date)
VALUES ('SpaceX Starship Navigation System', '2021-02-01');

INSERT INTO employee_department (department_id, employee_id)
VALUES (1, 1)

INSERT INTO employee_department (department_id, employee_id)
VALUES (1, 2)

INSERT INTO employee_department (department_id, employee_id)
VALUES (2, 3)

INSERT INTO employee_department (department_id, employee_id)
VALUES (2, 4)

INSERT INTO employee_department (department_id, employee_id)
VALUES (3, 5)

INSERT INTO employee_department (department_id, employee_id)
VALUES (3, 6)

INSERT INTO employee_department (department_id, employee_id)
VALUES (3, 7)

INSERT INTO employee_department (department_id, employee_id)
VALUES (3, 8)

INSERT INTO employee_project (project_id, employee_id)
VALUES (4, 5)

INSERT INTO employee_project (project_id, employee_id)
VALUES (1, 6)

INSERT INTO employee_project (project_id, employee_id)
VALUES (2, 7)

INSERT INTO employee_project (project_id, employee_id)
VALUES (3, 8)

COMMIT TRANSACTION;