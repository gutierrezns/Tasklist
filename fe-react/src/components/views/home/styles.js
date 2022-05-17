import { makeStyles } from '@mui/styles';

export const useStyles = makeStyles((theme) => ({
    root: {
        backgroundColor: 'lightgreen !important',
        minHeight: '100vh',
        maxWidth: '75%',
        margin: '0 auto',
        
        '& .MuiGrid-root': {
            padding:'10px 40px',
            [theme.breakpoints.down('desktop')]: {
                justifyContent: 'center',
            },
        },
    },

    title: {
        textAlign: 'center',
        padding: '20px 10px',
        color: 'white'
    },
}))
