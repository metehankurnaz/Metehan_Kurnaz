import React, { useState } from "react";

function Foods({ food }) {
  const [quantity, setQuantity] = useState(1);
  const [varient, setVarient] = useState("small");
  return (
    <div className="bg-light mt-5 shadow-lg p-3">
      <h1>Food Name</h1>
      <img
        src="https://www.unileverfoodsolutions.com.tr/konsept-uygulamalarimiz/sokak-lezzetleri/hamburger-malzemesi-secerken/jcr:content/parsys/content/textimage_copy_copy_628821058/image.transform/jpeg-optimized/image.1552661787858.jpg"
        style={{ height: "200px" }}
        className="img-fluid"
      ></img>

      <div className="flex-container">
        <div className="w-100">
          <p>Seçenekler</p>

          <select className="form-select" value={varient} onChange>
            <option value="1">Küçük</option>
          </select>
        </div>
        <div className="w-100">
          <p>Miktar</p>
          <select className="form-select" value="0">
            <option value="1">1</option>
          </select>
        </div>
      </div>
      <div className="flex-container">
        <div className="m-1 w-100 mt-3">
          <h1>Fiyat</h1>
          <div className="m-1 w-100 mt-3">
            <h1>Sepete Ekle</h1>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Foods;
