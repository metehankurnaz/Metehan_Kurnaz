const express = require('express'); //req kısaltması ile

const app = express();
const db = require('./db');
const cors = require('cors');
const FoodModel = require('./models/FoodModel');

app.use(cors());
app.use(express.json());

app.get('/getfoods', (req,res) => {
    FoodModel.find({}, (err,result) => {
        if (err) {
            res.send(err)
        }
        else {
            res.send(result)
        }
    });
});

app.listen(1001, () => {
    console.log("server bir şekilde çalışıyor :))");
});