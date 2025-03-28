import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import HomePage from "./pages/HomePage";
import TestPage from "./pages/TestPage";
import TutorialPage from "./pages/TutorialPage";

import NavBar from "./components/Navbar";
import { ChakraProvider, Theme } from "@chakra-ui/react";
import { system } from "@chakra-ui/react/preset";
import Footer from "./components/Footer";
import ScamDonationPage from "./pages/ScamDonationPage";

function App() {
  return (
    <ChakraProvider value={system}>
      <Router>
        <Theme appearance="dark">
          <NavBar />
          <Routes>
            <Route path="/" element={<HomePage />} />
            <Route path="/test" element={<TestPage />} />
            <Route path="/tutorial" element={<TutorialPage />} />
            <Route path="/scam" element={<ScamDonationPage />} />
          </Routes>
          <Footer />
        </Theme>
      </Router>
    </ChakraProvider>
  );
}

export default App;
