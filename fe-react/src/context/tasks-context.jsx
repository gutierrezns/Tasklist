import React, { useState, createContext, useMemo, useContext } from "react";

const TasksContext = createContext();

export const TasksProvider = (props) => {
  const [tasks, setTasks] = useState([]);

  const value = useMemo(() => {
    return {
        tasks,
        setTasks,
    };
  }, [tasks]);

  return <TasksContext.Provider value={value} {...props} />;
};

export const useTasks = () => {
  const context = useContext(TasksContext);
  if (!context) {
    throw new Error("useTasks must be into TasksContext provider");
  }
  return context;
};
