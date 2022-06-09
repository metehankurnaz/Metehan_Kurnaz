const express = require("express"); // req kısaltması ile lorem ipsum dolor sit amet
const app = express();
const db = require("./db");
const cors = require("cors");
const foodsRoute = require("./routes/foodsRoute");
const FoodModel = require("./models/FoodModel");

app.use(cors());
app.use(express.json());

// app.get("/getfoods", (req, res) => {
//   FoodModel.find({}, (err, result) => {
//     if (err) {
//       res.send(err);
//     } else {
//       res.send(result);
//     }
//   });
// });

app.use("/api/foods", foodsRoute);

app.listen(1001, () => {
  console.log("server bir şekilde çalışıyor :))))");
});
