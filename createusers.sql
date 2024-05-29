CREATE TABLE geo (
    id SERIAL PRIMARY KEY,
    lat VARCHAR(50),
    lng VARCHAR(50)
);

CREATE TABLE addresses (
    id SERIAL PRIMARY KEY,
    street VARCHAR(100),
    suite VARCHAR(50),
    city VARCHAR(50),
    zipcode VARCHAR(20),
    geo_id INT,
    FOREIGN KEY (geo_id) REFERENCES geo(id)
);

CREATE TABLE companies (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100),
    catch_phrase VARCHAR(255),
    bs VARCHAR(255)
);

CREATE TABLE users (
    id INT PRIMARY KEY,
    name VARCHAR(100),
    username VARCHAR(50),
    email VARCHAR(100),
    address_id INT,
    phone VARCHAR(50),
    website VARCHAR(100),
    company_id INT,
    FOREIGN KEY (address_id) REFERENCES addresses(id),
    FOREIGN KEY (company_id) REFERENCES companies(id)
);