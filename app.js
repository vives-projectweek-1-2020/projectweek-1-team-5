const express = require('express');
const path = require('path');

const mysql = require('mysql');

// Create connection

const db = mysql.createConnection({
    host     : 'localhost',
    user     : 'root',
    //password : 'secret'
    database : 'stores_and_customers' // AFTER DATABASE IS CREATED
});

// Connect

db.connect((err) => {
    if(err){
        throw err;
    }
    console.log('Mysql connected...');
});

const app = express();

// Set a static folder SOURCE: https://www.youtube.com/watch?v=L72fhGm1tfE
app.use(express.static(path.join(__dirname,'public')));

// Create DB

app.get('/createdb', (req,res) => {
    let sql = 'CREATE DATABASE stores_and_customers';
    db.query(sql, (err,result) => {
        if(err) throw err;
        console.log(result);
        res.send('Database created...')
    });
});

// Create table
app.get('/createcustomerstable', (req,res) => {
    let sql = 'CREATE TABLE customers(id INT AUTO_INCREMENT, PRIMARY KEY(id), name VARCHAR(32))';
    db.query(sql, (err,result) => {
        if(err) throw err;
        console.log(result);
        res.send('Customers table created...');
    })
});

// Insert customer
app.get('/addcustomer', (req,res) => {
    let post = {name:'First customer'};
    let sql = 'INSERT INTO customers SET ?';
    let query = db.query(sql, post, (err,result) => {
        if(err) throw err;
        console.log(result);
        res.send('Customer added...');
    });
});

// Select customers
app.get('/getcustomers', (req,res) => {
    let sql = 'SELECT * FROM customers';
    let query = db.query(sql, (err, results) => {
        if(err) throw err;
        console.log(results);
        res.send('Customers fetched...');
    });
});

// Select single customer
app.get('/getcustomer/:id', (req,res) => {
    let sql = `SELECT * FROM customers WHERE id = ${req.params.id}`;
    let query = db.query(sql, (err,result) => {
        if(err) throw err;
        console.log(result);
        res.send('Customer fetched...');
    });
});

// Update post
app.get('/updatecustomer/:id', (req,res) => {
    let newName = 'Updated name';
    let sql = `UPDATE customers SET name = '${newName}' WHERE id = ${req.params.id}`;
    let query = db.query(sql, (err,result) => {
        if(err) throw err;
        console.log(result);
        res.send('Customer updated');
    });
});

// Delete post
app.get('/deletecustomer/:id', (req,res) => {
    let sql = `DELETE FROM customers WHERE id = ${req.params.id}`;
    let query = db.query(sql, (err,result) => {
        if(err) throw err;
        console.log(result);
        res.send('Customer deleted...');
    });
});

app.listen('3000', () => {
    console.log('Server started on port 3000');
});