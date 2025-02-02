import { BrowserRouter as Router, Route, Routes} from "react-router-dom";
import HomePage from "./pages/HomePage";
import QuizPage from "./pages/QuizPage";
import TutorialPage from "./pages/TutorialPage";

import './App.css'


function App() {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<HomePage />} />
        <Route path="/quiz" element={<QuizPage />} />
        <Route path="/tutorial" element={<TutorialPage />} />
      </Routes>
    </Router>
  );
}

export default App
