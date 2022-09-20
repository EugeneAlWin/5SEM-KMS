import React from 'react';
import { Routes, Route } from 'react-router-dom';
import ContactsPage from '../pages/ContactsPage/ContactsPage.jsx';
import MainPage from '../pages/MainPage/MainPage.jsx';
import TheoryPage from '../pages/TheoryPage/TheoryPage.jsx';
export default function Main() {
  return (
    <Routes>
      <Route path="/" element={<MainPage />} />
      <Route path="/theory" element={<TheoryPage />} />
      <Route path="/structure" element={<h1>3</h1>} />
      <Route path="/simulator" element={<h1>4</h1>} />
      <Route path="/contacts" element={<ContactsPage />} />
    </Routes>
  );
}
