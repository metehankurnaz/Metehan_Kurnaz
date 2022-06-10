const mongoose = require("mongoose");

mongoose.connect(
  "mongodb+srv://admin:Qwe123.@cluster0.qd5gr.mongodb.net/yemek-app?retryWrites=true&w=majority"
);

var db = mongoose.connection;

db.on("connected", () => {
  console.log("Mongo DB Bağlantısı Gayet İyi");
});

db.on("error", () => {
  console.log("Mongo DB Bağlantısı Hatalı");
});

module.exports = mongoose;
