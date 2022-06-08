const mongoose = require("mongoose");

mongoose.connect(
  "mongodb+srv://barbaros:1234@cluster0.m9pr8df.mongodb.net/yemek-app?retryWrites=true&w=majority"
);

var db = mongoose.connection;

db.on("connected", () => {
  console.log("Mongo DB Bağlantısı Gayet İyi");
});

db.on("error", () => {
  console.log("Mongo DB Bağlantısı Hatalı");
});

module.exports = mongoose;
