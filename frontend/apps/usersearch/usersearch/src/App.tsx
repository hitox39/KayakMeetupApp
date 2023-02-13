import Layout from './Components/Layout';
import Sidebar from './Components/Sidebar';
import Dashboard from './Components/Dashboard';
export default function App() {

  return <Layout component={<Dashboard />} />;
  
}

