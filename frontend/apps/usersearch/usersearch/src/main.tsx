import React from 'react';
import ReactDOM from 'react-dom/client';
import App from './App';
import {
  createBrowserRouter,
  BrowserRouter,
  Route,
  Routes,
  RouterProvider,
} from "react-router-dom";
import Layout from './Components/Layout';
import Dashboard from './Components/Dashboard';
import AddCasualEvent from './Components/Groups/AddEvent/AddCasualForm';
import AddEvents from './Components/Groups/AddEvent/AddEvents';
import RaceEvents from './Components/Groups/Events/RaceEvents';
import FishingEvents from './Components/Groups/Events/FishingEvents';
import CasualEvents from './Components/Groups/Events/CasualEvents';



ReactDOM.createRoot(document.getElementById('root') as HTMLElement).render(
  <BrowserRouter>
    <Routes>
      <Route index element={<App />} />
      <Route 
        path={'/'}
        element={<Layout component={<Dashboard />}/>}
       /> 
       <Route 
        path={'/addEvents'}
        element={<Layout component={<AddEvents />}/>}
       />  
       <Route 
        path={'/CasualEvents'}
        element={<Layout component={<CasualEvents />}/>}
       /> 
       <Route 
        path={'/FishingEvents'}
        element={<Layout component={<FishingEvents />}/>}
       /> 
       <Route 
        path={'/RaceEvents'}
        element={<Layout component={<RaceEvents />}/>}
       /> 
    </Routes>
  </BrowserRouter>
  );
