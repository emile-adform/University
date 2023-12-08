CREATE TABLE departamentas(
	id serial PRIMARY KEY,
	pavadinimas varchar(50)
);

CREATE INDEX idx_departamentas
ON departamentas (id);

CREATE TABLE studentas (
	id serial PRIMARY KEY,
	vardas varchar(50),
	pavarde varchar(50)
);

CREATE INDEX idx_studentas
ON studentas (id);

CREATE TABLE paskaita (
	id serial PRIMARY KEY,
	pavadinimas varchar(50)
);

CREATE INDEX idx_paskaita
ON paskaita (id);

CREATE TABLE departamentas_paskaita (
	departamentas_id int,
	paskaita_id int,
	PRIMARY KEY (departamentas_id, paskaita_id),
	FOREIGN KEY (departamentas_id) REFERENCES departamentas(id),
	FOREIGN KEY (paskaita_id) REFERENCES paskaita(id)
);

CREATE TABLE studentas_departamentas (
	studentas_id int,
	departamentas_id int,
	PRIMARY KEY (studentas_id),
	FOREIGN KEY (studentas_id) REFERENCES studentas (id),
	FOREIGN KEY (departamentas_id) REFERENCES departamentas (id)
);
