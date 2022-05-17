import { getAll, putTask } from "./requester";

export default class service {
  static INSTANCE = new service();

  tasks;

  constructor() {
    this.tasks = null;
  }

  getTasks = async () => {
    try {
      const titles = await getAll({
        path: `api/tasks`,
      });
      return titles;
    } catch (error) {
      console.log(error);
    }
  };

  completeTask = async (task) => {
    try {
      const taskResponse = await putTask({
        path: `api/tasks/${task.id}`,
        body: {
          id: task.id,
          title: task.title,
          isCompletes: true
          }
      });
      return taskResponse;
    } catch (error) {
      console.log(error);
     
    }
  };
}
