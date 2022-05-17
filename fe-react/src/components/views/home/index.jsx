import React, { useEffect } from "react";

import Grid from '@mui/material/Grid';
import Paper from '@mui/material/Paper';
import Typography from '@mui/material/Typography';
import { useStyles } from "./styles";

import { useTasks } from "../../../context/tasks-context";
import TasksService from "../../../services/taskServices";


import TaskList from "../../tasks-list";

const Home = () => {
    const { tasks, setTasks } = useTasks();
    const classes = useStyles();

    const setDataTasks = async () => {
        try {
            const titles = await TasksService.INSTANCE.getTasks();
            setTasks(titles);
        } catch (error) {
            console.log(error)
        }
    };

    useEffect(() => {
        setDataTasks();
        // eslint-disable-next-line
    }, []);

    const amountOfTasksText = tasks && `${tasks.length > 1 ? 'are' : 'is'} ${tasks.length} ${tasks.length > 1 ? 'tasks' : 'task'}`

    return (
        <Paper className={classes.root}>
            <div className={classes.title}>
                <Typography variant="h4">
                    TO-DO List
                </Typography>
                { tasks && !!tasks.length &&
                    <Typography variant="p">
                        There {amountOfTasksText} to do
                    </Typography>
                }
            </div>
            <Grid container>
                <TaskList tasks={tasks} />
            </Grid>
        </Paper>
    );
};

export default Home;
