import { Area } from "./components/Area/Area";
import React from "react";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import AreaAdd from "./components/Area/AreaAdd";


const StageRoutes = () => {
    return (
    <BrowserRouter>
      <Routes>
        <Route path="/" >
        <Route index element={<Area />} />   
        <Route path="Area" element={<Area />} />   
        <Route path="AdicionarArea" element={<AreaAdd />} />
        </Route>
      </Routes>
    </BrowserRouter>
  );
}
//<Route path="*" element={<NoPage />} />
export {StageRoutes};