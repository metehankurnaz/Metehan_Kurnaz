const mongoose = require('mongoose');

mongoose.connect("mongodb+srv://admin:admin123@cluster0.qd5gr.mongodb.net/yemek-app?retryWrites=true&w=majority")

var db = mongoose.connection;

db.on('connected', () => {
    console.log("Mongo DB Bağlantısı Başarılı!");
});

db.on('error', () => {
    console.log("Mongo DB Bağlantısı Başarısız!");
});

module.exports = mongoose;