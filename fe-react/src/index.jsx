import React from "react";
import ReactDOM from "react-dom";

import App from "./App";
import { TasksProvider } from "./context/tasks-context";

ReactDOM.render(
  <React.StrictMode>
    <TasksProvider>
      <App />
    </TasksProvider>
  </React.StrictMode>,
  document.getElementById("root")
);
