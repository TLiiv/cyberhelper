import { BrowserRouter as Router, Route, Routes} from "react-router-dom";
import HomePage from "./pages/HomePage";
import TestPage from "./pages/TestPage";
import TutorialPage from "./pages/TutorialPage";

import './App.css'
import NavBar from "./components/Navbar";
import { ChakraProvider } from "@chakra-ui/react";
import { system } from "@chakra-ui/react/preset";


function App() {
  return (
    <ChakraProvider value={system}>
    <Router>
      <NavBar />
      <Routes>
        <Route path="/" element={<HomePage />} />
        <Route path="/test" element={<TestPage />} />
        <Route path="/tutorial" element={<TutorialPage />} />
      </Routes>
    </Router>
    </ChakraProvider>
  );
}

export default App
