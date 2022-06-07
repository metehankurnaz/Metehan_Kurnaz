import React, { useEffect, useState } from "react";
import Foods from "../components/Foods";
import axios from "axios";

function Homepage() {
  const [foods, setFoods] = useState({});
  useEffect(() => {
    axios
      .get("http://localhost:1001/getfoods")
      .then((response) => {
        setFoods(response.data);
      })
      .catch((err) => console.log(err));
  }, []);

  return (
    <div>
      <div className="row">
        {foods.map((food) => {
            <div className="col-md-4">
          <Foods  food={food} />
        </div>
        })}
      </div>
    </div>
  );
}

export default Homepage;
